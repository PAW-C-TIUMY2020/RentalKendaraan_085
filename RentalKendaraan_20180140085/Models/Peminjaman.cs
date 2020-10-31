using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }
        [DisplayName("Tanggal Peminjaman")]
        public DateTime? TglPeminjaman { get; set; }
        [DisplayName("Kendaraan")]
        public int? IdKendaraan { get; set; }
        [DisplayName("Customer")]
        public int? IdCustomer { get; set; }
        [DisplayName("Jaminan")]
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public Customer IdPeminjamanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
