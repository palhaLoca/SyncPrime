using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.ApplicationServices.Core;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using SyncPrime.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SyncPrime.Domain.CadSevices
{
    public class AutoCadService : IAutoCadService
    {
        public List<object> GetCurrentElement(CadEmun.TypedValue typedValue)
        {
            List<object> lines = new List<object>();
            try
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor edt = doc.Editor;               

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, typedValue.ToString()), 0);
                    SelectionFilter sf = new SelectionFilter(tv);
                    PromptSelectionResult psr = edt.SelectAll(sf);

                    if (psr.Status == PromptStatus.OK)
                    {
                        SelectionSet ss = psr.Value;
                        foreach (SelectedObject sObj in ss)
                        {
                            object obj = trans.GetObject(sObj.ObjectId, OpenMode.ForRead);                            
                            if (obj != null)
                                lines.Add(obj);
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
