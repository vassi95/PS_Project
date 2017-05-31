using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KursovaPS.View
{
    /// <summary>
    /// Interaction logic for LooseWin.xaml
    /// </summary>
    public partial class LoseWin : Window
    {
        public LoseWin()
        {
            InitializeComponent();
            mediaElement1.Play();
        }
    }
}
