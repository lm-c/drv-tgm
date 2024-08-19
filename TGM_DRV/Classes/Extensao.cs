using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TGM_DRV {
  internal static class Extensao {
    public static Color StringToColor(this string valor) {
      try {
        var spl = valor.Split(',');
        int R = Convert.ToInt32(spl[0]);
        int G = Convert.ToInt32(spl[1]);
        int B = Convert.ToInt32(spl[2]);

        return Color.FromArgb(R, G, B);
      } catch (Exception) {
        return Color.FromArgb(123, 123, 123);
      }
    }

    public static string ColorToString(this Color cor) {
      try {
        return $"{cor.R},{cor.G},{cor.B}";
      } catch (Exception) {
        return "123,123,123";
      }
    }

    public static string ToBase64String(this Image image) {
      if (image == null) return null;
      try {
        byte[] bytesOfImage = image.ToByteArray();
        Image newImage = bytesOfImage.ToImage();

        using (var m = new System.IO.MemoryStream()) {
          newImage.Save(m, newImage.RawFormat);
          byte[] imageBytes = m.ToArray();
          return Convert.ToBase64String(imageBytes);
        }
      } catch (Exception ex) {
        return null;
      }
    }

    public static byte[] ToByteArray(this Image imagem) {
      if (imagem == null) return null;
      try {
        using (var ms = new System.IO.MemoryStream()) {
          imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
          return ms.ToArray();
        }
      } catch { return null; }
    }

    public static Image ToImage(this byte[] bytes) {
      if (bytes == null) return null;
      try {
        using (var ms = new System.IO.MemoryStream(bytes))
          return Image.FromStream(ms);

      } catch { return null; }
    }

    public static Image SetImageQuality(this Image image, int quality/*, int base64Length = 0*/) {
      if ((quality < 1) || (quality > 100)) {
        //MsgBox.Show("Qualidade da imagem deve estar entre 1 e 100", "Qualidade Inválida",
        //    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        quality = 81;
        return image;
      }

      float nPorcentagem = ((float)quality / 100);

      int fonteLargura = image.Width;
      int fonteAltura = image.Height;

      int destWidth = (int)(fonteLargura * nPorcentagem);
      int destHeight = (int)(fonteAltura * nPorcentagem);

      Bitmap bmImagem = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);

      bmImagem.SetResolution(image.HorizontalResolution, image.VerticalResolution);

      Graphics grImagem = Graphics.FromImage(bmImagem);
      grImagem.InterpolationMode = InterpolationMode.HighQualityBicubic;

      grImagem.DrawImage(image,
         new Rectangle(0, 0, destWidth, destHeight),
         new Rectangle(0, 0, fonteLargura, fonteAltura),
         GraphicsUnit.Pixel);

      grImagem.Dispose();

      GC.Collect();

      return bmImagem;
    }

  }
}
