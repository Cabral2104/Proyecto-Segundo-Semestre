using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Segundo_Semestre
{
    public partial class Extras1 : Form
    {
        private long GAMartinPrecioTotal;
        private int GAMartin;
        private long GAGibsonPrecioTotal;
        private int GAGibson;
        private long GATaylorPrecioTotal;
        private int GATayor;
        private long GEFenderPrecioTotal;
        private int GEFender;
        private long GEIbanezPrecioTotal;
        private int GEIbanez;
        private long GEGibsonPrecioTotal;
        private int GEGibson;
        private long BEYamahaPrecioTotal;
        private int BEYamaha;
        private long BEFenderPrecioTotal;
        private int BEFender;
        private long BERedSubPrecioTotal;
        private int BERedSub;
        private int bEFeder;
        private long APSelviPrecioTotal;
        private int APSelvi;
        private long APSeltaPrecioTotal;
        private int APSelta;
        private long VStenorPrecioTotal;
        private int VStenor;
        private long VSinfonie24PrecioTotal;
        private int VSinfonie24;
        private long BACrushPrecioTotal;
        private int BACrush;
        private long BAYamahaPrecioTotal;
        private int BAYamaha;
        private long BAMapexPrecioTotal;
        private int BAMapex;
        private long BATamaPrecioTotal;
        private int BATama;
        private long BELYamahaPrecioTotal;
        private int BELYamaha;
        private long BELRonaldPrecioTotal;
        private int BELRonald;
        private long TAdams32PrecioTotal;
        private int TAdams32;
        private long TMajestic32PrecioTotal;
        private int TMajestic32;
        private long TACharlsPrecioTotal;
        private int TACharls;
        private long TAXOPrecioTotal;
        private int TAXO;
        private long BAudiotekPrecioTotal;
        private int BAudiotek;
        private long ATrompetaPrecioTotal;
        private int ATrompeta;
        private long AXilófonoPrecioTotal;
        private int AXilófono;
        private long AAcordeónPrecioTotal;
        private int AAcordeón;
        private long AFlutaPrecioTotal;
        private int AFluta;


        public Extras1(long GAMartinPrecioTotal, int GAMartin, long GAGibsonPrecioTotal, int GAGibson, long GATaylorPrecioTotal, int GATaylor, int GEFender, long GEFenderPrecioTotal, int GEIbanez, long GEIbanezPrecioTotal,int GEGibson, long GEGibsonPrecioTotal, int BEYamaha, long BEYamahaPrecioTotal,int BEFender, long BEFenderPrecioTotal, int BERedSub, long BERedSubPrecioTotal, int APSelvi, long APSelviPrecioTotal, int APSelta, long APSeltaPrecioTotal, int VStenor, long VStenorPrecioTotal, int VSinfonie24, long VSinfonie24PrecioTotal, int BACrush, long BACrushPrecioTotal, int BAYamaha,long BAYamahaPrecioTotal, int BAMapex, long BAMapexPrecioTotal, int BATama, long BATamaPrecioTotal, int BELYamaha, long BELYamahaPrecioTotal, int BELRonald, long BELRonaldPrecioTotal, int TAdams32, long TAdams32PrecioTotal, int TMajestic32, long TMajestic32PrecioTotal, int TACharls, long TACharlsPrecioTotal, int TAXO, long TAXOPrecioTotal, int BAudiotek, long BAudiotekPrecioTotal, int ATrompeta, long ATrompetaPrecioTotal, int AXilófono, long AXilófonoPrecioTotal, int AAcordeón, long AAcordeónPrecioTotal, int AFluta, long AFlutaPrecioTotal)
        {
            InitializeComponent();
            this.GAMartin = GAMartin;
            this.GAMartinPrecioTotal = GAMartinPrecioTotal;
            this.GAGibson = GAGibson;
            this.GAGibsonPrecioTotal = GAGibsonPrecioTotal;
            this.GATayor= GATaylor;
            this.GATaylorPrecioTotal = GATaylorPrecioTotal;
            this.GEFender= GEFender;
            this.GEFenderPrecioTotal = GEFenderPrecioTotal;
            this.GEIbanez = GEIbanez;
            this.GEIbanezPrecioTotal = GEIbanezPrecioTotal;
            this.GEGibson = GEGibson;
            this.GEGibsonPrecioTotal = GEGibsonPrecioTotal;
            this.BEYamaha = BEYamaha;
            this.BEYamahaPrecioTotal = BEYamahaPrecioTotal;
            this.BEFender = BEFender;
            this.BEFenderPrecioTotal=BEFenderPrecioTotal;
            this.BERedSub = BERedSub;
            this.BERedSubPrecioTotal = BERedSubPrecioTotal;
            this.APSelvi = APSelvi;
            this.APSelviPrecioTotal = APSelviPrecioTotal;
            this.APSelta = APSelta;
            this.APSeltaPrecioTotal = APSeltaPrecioTotal;
            this.VStenor = VStenor;
            this.VStenorPrecioTotal = VStenorPrecioTotal;
            this.VSinfonie24 = VSinfonie24;
            this.VSinfonie24PrecioTotal = VSinfonie24PrecioTotal;
            this.BACrush = BACrush;
            this.BACrushPrecioTotal = BACrushPrecioTotal;
            this.BAYamaha = BAYamaha;
            this.BAYamahaPrecioTotal = BAYamahaPrecioTotal;
            this.BAMapex = BAMapex;
            this.BAMapexPrecioTotal = BAMapexPrecioTotal;
            this.BATama = BATama;
            this.BATamaPrecioTotal = BATamaPrecioTotal;
            this.BELYamaha = BELYamaha;
            this.BELYamahaPrecioTotal = BELYamahaPrecioTotal;
            this.BELRonald = BELRonald;
            this.BELRonaldPrecioTotal = BELRonaldPrecioTotal;
            this.TAdams32 = TAdams32;
            this.TAdams32PrecioTotal = TAdams32PrecioTotal;
            this.TMajestic32 = TMajestic32;
            this.TMajestic32PrecioTotal = TMajestic32PrecioTotal;
            this.TACharls = TACharls;
            this.TACharlsPrecioTotal = TACharlsPrecioTotal;
            this.TAXO = TAXO;
            this.TAXOPrecioTotal = TAXOPrecioTotal;
            this.BAudiotek = BAudiotek;
            this.BAudiotekPrecioTotal = BAudiotekPrecioTotal;
            this.ATrompeta = ATrompeta;
            this.ATrompetaPrecioTotal = ATrompetaPrecioTotal;
            this.AXilófono = AXilófono;
            this.AXilófonoPrecioTotal = AXilófonoPrecioTotal;
            this.AAcordeón = AAcordeón;
            this.AAcordeónPrecioTotal = AAcordeónPrecioTotal;
            this.AFluta = AFluta;
            this.AFlutaPrecioTotal = AFlutaPrecioTotal;
            
        }

        private void btnCerrarExtras1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       

        private void dtgCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void Extras1_Load(object sender, EventArgs e)
        {

        }
    }
}
