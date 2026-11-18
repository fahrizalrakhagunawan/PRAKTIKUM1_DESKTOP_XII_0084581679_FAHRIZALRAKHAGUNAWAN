-- Active: 1794273757253@@127.0.0.1@3306@db_apotek_petugas
CREATE DATABASE `db_apotek_petugas`;
USE `db_apotek_petugas`;

DROP TABLE IF EXISTS `tb_apoteker`;
CREATE TABLE `tb_apoteker` (
    `id_petugas` INT AUTO_INCREMENT PRIMARY KEY,
    `username` VARCHAR(50) NOT NULL UNIQUE,
    `password` VARCHAR(100) NOT NULL,
    `nama_petugas` VARCHAR(100) NOT NULL,
    `shift` ENUM('Pagi', 'Siang', 'Malam') NOT NULL DEFAULT 'Pagi',
    `role` ENUM('Apoteker', 'Asisten Apoteker', 'Kasir Apotek') NOT NULL DEFAULT 'Kasir Apotek',
    `status_aktif` TINYINT(1) NOT NULL DEFAULT 1,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Data Dummy Awal
-- Catatan kata sandi:
-- apt01 : resep123 (status: 1 = Aktif)
-- kasir_apt : bayar456 (status: 1 = Aktif)
-- apt_cuti : istirahat (status: 0 = Nonaktif)

INSERT INTO `tb_apoteker` (`id_petugas`, `username`, `password`, `nama_petugas`, `shift`, `role`, `status_aktif`) VALUES
(1, 'apt01', 'resep123', 'Apt. Sarah Amelia, S.Farm', 'Pagi', 'Apoteker', 1),
(2, 'kasir_apt', 'bayar456', 'Dimas Prasetyo', 'Siang', 'Kasir Apotek', 1),
(3, 'apt_cuti', 'istirahat', 'Bambang Irawan', 'Malam', 'Asisten Apoteker', 0);