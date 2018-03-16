using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTournois
{
    public partial class CC_Tournois : Component
    {
        public CC_Tournois()
        {
            InitializeComponent();
        }

        public CC_Tournois(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
