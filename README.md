# 🎮 AR Marker → VR 360 Experience  
Project Base — Tugas UAS AR / VR  
Kelompok 3

---

## 📌 Overview
Proyek ini menggabungkan **Augmented Reality (AR)** berbasis marker dan **Virtual Reality (VR)** berbasis video 360° dalam satu aplikasi.  
Pengguna memulai pengalaman dari AR dengan mendeteksi marker → menekan tombol **Masuk VR** → aplikasi melakukan **fade-out transition** → berpindah ke **VR Scene** untuk menonton video 360 Minecraft.

Proyek dikembangkan menggunakan:
- **Unity 6 (6000.2f1)**
- **Vuforia Engine**
- **GoogleVR / XR Basic Setup**
- **C# Scripts (Scene Transition, AR Handler, VR Controls)**

---

# 🚀 Cara Build & Run

## 1️⃣ Instalasi yang Dibutuhkan
- Unity Version: **6000.2f1**
- Android Build Support
- Vuforia Engine (via Project Settings)
- XR Plugin Management

---

## 2️⃣ Cara Menjalankan Proyek di Unity

### **A. Mode AR (SampleScene)**
1. Buka Unity → Load Project
2. Buka scene:
   Assets/Scenes/SampleScene.unity
3. Pastikan:
- ARCamera sudah aktif
- Image Target telah memiliki marker
- Button “Masuk VR” mengarah ke script `SceneTransitionManager`

### **B. Mode VR (VR_Scene)**
1. Buka scene:
   Assets/Scenes/VR_Scene.unity
2. Pastikan:
- Skybox360 sudah aktif
- VideoPlayer diarahkan ke `Assets/Resources/Video/Minecraft-Video.mp4`
- Tombol “Keluar VR” memakai script `BackToAR.cs`

### **C. Build Android**
1. File → Build Settings  
2. Pilih **Android**
3. Add scenes in build:
   0 — SampleScene
   1 — VR_Scene
4. Klik **Build** → Install APK ke HP.

---

# 🔄 Alur AR → VR

1. Kamera mendeteksi marker Minecraft.
2. UI Button muncul: **Masuk VR**.
3. Pengguna menekan tombol.
4. Script `FadeTransition.cs` menjalankan animasi fade-out.
5. `SceneTransitionManager.cs` memuat scene VR.
6. VR_Scene menampilkan video 360° Minecraft.
7. Tombol **Keluar VR** membawa pengguna kembali ke AR (fade-out lagi).

---

# 🎯 Fitur Utama

### 🧩 AR Marker Tracking
- Menggunakan **Vuforia**
- Stabil dan cepat mendeteksi marker

### 🎬 VR 360 Video Experience
- Video 360 resolusi tinggi
- Menggunakan Skybox + VideoPlayer

### 🌑 Smooth Fade Transition
- Transisi AR ↔ VR menggunakan panel UI
- Animasi fade-out & fade-in

### 🔊 Audio 360° (Opsional)
- Bisa menambahkan suara Minecraft
- Audio source otomatis play saat VR aktif

### 🔙 Back to AR
- Tombol **Keluar VR** men-trigger transition
- Kembali ke SampleScene

---

# 📦 Video & Asset Eksternal

Karena GitHub memiliki limit 100MB, seluruh video dan file besar disimpan di Google Drive.

### 📥 [Assets\Resources\Video](https://drive.google.com/drive/folders/1TCinOuc1otJbb3nK2Tmf90beLYx8ha87?usp=sharing)

### 📥 [Aplikasi Hasil Build](https://drive.google.com/drive/folders/1rSSt7W_3GGmf0X_B3p2FkZuFo0_l5cC7?usp=sharing)

### 📥 [Video Demo UAS]( https://drive.google.com/drive/folders/1g0JUjGxB4gfBJVSMCv8RSqPa7dRSGkt5?usp=sharing)

---

# 🧑‍🤝‍🧑 Pembagian Peran Kelompok

| Nama                       |Nim              | Peran| Tugas|
|----------------------------|-----------------|------|------|
| Moh Fiqhi                  | F55124108       | NULL | NULL |
| Dareean Ahmad Raffi Mardin | F55124086       | NULL | NULL |
| I Made Aditya Pramana      | F55124087       | NULL | NULL |
| Mia Islamia                | F55124114       | NULL | NULL |

---

# 🧪 Pengujian (Usability + Performance)

### ✔ Usability Test
- Apakah marker mudah terdeteksi?
- Apakah tombol Masuk VR mudah ditemukan?
- Apakah transisi AR → VR halus?
- Apakah tombol Keluar VR berfungsi?

### ✔ Performance Test
- FPS stabil di atas 30 FPS
- Video 360 berjalan smooth
- Tidak terjadi crash atau freeze saat switching scene

---
