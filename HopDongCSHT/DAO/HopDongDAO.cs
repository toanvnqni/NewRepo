using HopDongCSHT.HDContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HopDongCSHT.DAO
{
    public class HopDongDAO
    {
        private CSHT_QNHEntities db = new CSHT_QNHEntities();

        public HopDongDAO()
        {

        }


        public List<Luu_File> DetailsHD(int? id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                var modelMap = (from m in db.Map_HD_File
                                where m.HD_ID == id
                                select m.File_ID).ToList();
                if (modelMap.Count > 0)
                {

                    var modelFile = (from m in db.Luu_File
                                     where modelMap.Contains(m.ID)
                                     select m).ToList();
                    return modelFile;
                }

            }
            return new List<Luu_File>();
        }
    }
}