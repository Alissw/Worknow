using System.Drawing;

namespace lib
{
    public class LabelMenu : System.Windows.Forms.Label
    {
        public LabelMenu(){
            this.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = new Size(232, 20);
        }
    }
}