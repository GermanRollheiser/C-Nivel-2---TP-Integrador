using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helper
{
    public class CargarImagen
    {
        
        public void toLoadPic(PictureBox box, string pic)
        {
            try
            {
                box.Load(pic);
            }
            catch (Exception)
            {
                box.Load("https://tagcor.com/jobs_assets/images/icons/error.png");
            }
        }

        public void toLoadPicAlta(PictureBox box, string pic)
        {
            try
            {
                box.Load(pic);
            }
            catch (Exception)
            {
                box.Image = Image.FromFile("C:\\Repositorio GitHub\\C-sharp-Nivel-2-TP-Integrador\\presentacion\\Resources\\upload-design-layer.png");
            }
        }
    }
}
