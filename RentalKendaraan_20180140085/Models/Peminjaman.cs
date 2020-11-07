using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [DisplayName("Tanggal Peminjaman")]
        public DateTime TglPeminjaman { get; set; }
        [Column(TypeName ="varchar(20)")]
        [DisplayName("Kendaraan")]
        public int IdKendaraan { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Customer")]
        public int IdCustomer { get; set; }
        [Column(TypeName = "varchar(15)")]
        [DisplayName("Jaminan")]
        public int IdJaminan { get; set; }
        [Column(TypeName = "int")]
        public int Biaya { get; set; }

        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public Customer IdPeminjamanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
        public int? IdPeminjaman { get; internal set; }
    }
}
