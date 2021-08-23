using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterMaterialUnitConv
    {
        public string Materialcode { get; set; }
        public string Alterunit { get; set; }
        public int Numerator { get; set; }
        public int Denumerator { get; set; }
        public decimal? Volumeweight { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string Dimensionunit { get; set; }
        public decimal? Volume { get; set; }
        public string Volumeunit { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
