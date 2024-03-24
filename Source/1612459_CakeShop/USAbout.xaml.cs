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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1612459_CakeShop
{
    /// <summary>
    /// Interaction logic for USAbout.xaml
    /// </summary>
    public partial class USAbout : UserControl
    {
        public USAbout()
        {
            InitializeComponent();
            t.Text = "Sweet&Sour uniquely combines the sensibilities of the old-fashioned sweet shop of your childhood with contemporary creativity and innovation for every kind of lover of sweets!";
            tt.Text = "From custom made cakes, pies, tarts, brownies to the most beloved Cupcakes by Sweet&Sour, we use nothing less than the finest of ingredients from around the world to provide the highest quality baked goods to satisfy the deepest and sweetest of desires. Our creative vision elevates the familiar, creating unique flavor and designs such as the rich chocolate cake topped with graham cracker crisps and fluffy toasted marshmallow frosting of the S’Mores Cupcake.";
            ttt.Text = "Come visit Sweet&Sour and enjoy our sweets with your family and friends!";
        }
    }
}
