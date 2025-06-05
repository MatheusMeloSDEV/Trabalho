using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUSA
{
    public class MAPA : OrgaoAnuente
    {
        public DateTime? InspecaoMapa { get; set; } = (DateTime?)null;
        public bool CheckInspecaoMapa { get; set; } = false;
    }
    public class DECEX : OrgaoAnuente
    {
        public DateTime? InspecaoDecex { get; set; } = (DateTime?)null;
        public bool CheckInspecaoDecex { get; set; } = false;
    }
    public class ANVISA : OrgaoAnuente
    {
        public DateTime? InspecaoAnvisa { get; set; } = (DateTime?)null;
        public bool CheckInspecaoAnvisa { get; set; } = false;
    }
    public class IBAMA : OrgaoAnuente
    {
        public DateTime? InspecaoIbama { get; set; } = (DateTime?)null;
        public bool CheckInspecaoIbama { get; set; } = false;
    }
    public class INMETRO : OrgaoAnuente
    {
        public DateTime? InspecaoInmetro { get; set; } = (DateTime?)null;
        public bool CheckInspecaoInmetro { get; set; } = false;
    }
}