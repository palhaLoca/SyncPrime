using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.ApplicationServices.Core;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System;
using System.Collections.Generic;

namespace SyncPrime.Domain.CadSevices
{
    public class AutoCadService : IAutoCadService
    {
        public List<Line> GetCurrentLines()
        {
            List<Line> lines = new List<Line>();
            try
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor edt = doc.Editor;               

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "LINE"), 0);
                    SelectionFilter sf = new SelectionFilter(tv);
                    PromptSelectionResult psr = edt.SelectAll(sf);

                    if (psr.Status == PromptStatus.OK)
                    {
                        SelectionSet ss = psr.Value;
                        foreach (SelectedObject sObj in ss)
                        {
                            Line line = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as Line;
                            if (line != null)
                                lines.Add(line);
                        }
                    }
                    else
                    {
                        edt.WriteMessage("no object selected.");
                    }
                }

               
            }
            catch (Exception ex)
            {

            }
            return lines;
        }
    }
}
