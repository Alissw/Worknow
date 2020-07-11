using System.Drawing;

namespace lib
{
    public class Label : System.Windows.Forms.Label
    {
        public Label(){
            this.Font = new Font(this.Font, FontStyle.Bold);
        }
    }
}