using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinetModels
{
    public class Inventario
    {
        public string COD_CIA { get; set; }

        public string COMPANIA_VENTA_3 { get; set; }

        public string ALMACEN_VENTA { get; set; }

        public string TIPO_MOVIMIENTO { get; set; }

        public string TIPO_DOCUMENTO { get; set; }

        public string NRO_DOCUMENTO { get; set; }

        public string COD_ITEM_2 { get; set; }
        public string FECHA_TRANSACCION { get; set; }
    }

    internal class InventarioMapper : ClassMapper<Inventario>
    {
        public InventarioMapper()
        {
            Table("MOV_INVENTARIO");
            Map(m => m.COD_CIA).Key(KeyType.Assigned);
            Map(m => m.COMPANIA_VENTA_3).Key(KeyType.Assigned);
            Map(m => m.ALMACEN_VENTA).Key(KeyType.Assigned);
            Map(m => m.TIPO_MOVIMIENTO).Key(KeyType.Assigned);
            Map(m => m.TIPO_DOCUMENTO).Key(KeyType.Assigned);
            Map(m => m.NRO_DOCUMENTO).Key(KeyType.Assigned);
            Map(m => m.COD_ITEM_2).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
