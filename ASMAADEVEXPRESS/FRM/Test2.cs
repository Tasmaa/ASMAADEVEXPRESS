using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class Test2 : DevExpress.XtraEditors.XtraForm
    {
        //public Test2()
        //{
       
        //    InitializeComponent();
        //    InitializeTables();
        //    gridControl1.DataSource = lstTopList;

        //    gridControl1.ViewRegistered += GridControl1_ViewRegistered;
        //    gridView1.MasterRowGetLevelDefaultView += View_MasterRowGetLevelDefaultView;
        //}

        //private void GridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        //{
        //    var view = e.View as DevExpress.XtraGrid.Views.Grid.GridView;
        //    if (view == null)
        //        return;
        //    view.MasterRowGetLevelDefaultView += View_MasterRowGetLevelDefaultView;
        //}

        //private void View_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        //{
        //    var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
        //    if (view.GetRelationName(e.RowHandle, e.RelationIndex) == "DiskTable")
        //        e.DefaultView = gridView2;
        //    else
        //        e.DefaultView = cardView1;
        //}

    }
}