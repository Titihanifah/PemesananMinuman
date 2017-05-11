--
-- Database: `chachamilktea`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akun`
--

CREATE TABLE `akun` (
  `id` int(5) NOT NULL,
  `jenis_akun` enum('admin','karyawan') NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`id`, `jenis_akun`, `username`, `password`) VALUES
(1, 'admin', 'admin', 'admin'),
(2, 'admin', 'Sania', 'sania'),
(3, 'karyawan', 'Dewi', 'dewi'),
(14, 'karyawan', 'Heni', 'heni');

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `id_customer` int(5) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `email` varchar(25) NOT NULL,
  `telepon` varchar(13) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `poin` int(4) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`id_customer`, `nama`, `tempat_lahir`, `tgl_lahir`, `email`, `telepon`, `alamat`, `poin`) VALUES
(1, 'meryyyy', 'medann', '2017-05-10', 'mery@gmail.commmmmmmm', '2324433243', 'Sleman', 1),
(2, 'waew', 'wfeew', '2017-05-01', 'efwewa', '32432', 'efewaf', 2),
(3, 'heni', 'solo', '2017-05-07', 'heni@gmail.com', '08283643', 'soloensis', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `id` int(5) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `alamat` int(50) NOT NULL,
  `telepon` int(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `minuman`
--

CREATE TABLE `minuman` (
  `id` int(5) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `harga` int(6) NOT NULL,
  `stock` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `toping`
--

CREATE TABLE `toping` (
  `id` int(5) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `harga` int(6) NOT NULL,
  `stock_toping` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `toping`
--

INSERT INTO `toping` (`id`, `nama`, `harga`, `stock_toping`) VALUES
(1, 'oreo', 1000, 25);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int(5) NOT NULL,
  `id_minuman` int(5) NOT NULL,
  `id_toping` int(5) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `jumlah` int(10) NOT NULL,
  `total` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id_customer`);

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `minuman`
--
ALTER TABLE `minuman`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `toping`
--
ALTER TABLE `toping`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD UNIQUE KEY `id_toping` (`id_toping`),
  ADD UNIQUE KEY `id_minuman` (`id_minuman`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `minuman`
--
ALTER TABLE `minuman`
  ADD CONSTRAINT `minuman_ibfk_1` FOREIGN KEY (`id`) REFERENCES `transaksi` (`id_minuman`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`id_toping`) REFERENCES `toping` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
