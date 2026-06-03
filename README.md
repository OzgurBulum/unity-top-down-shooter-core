# Unity Top-Down Shooter Core

A 2D top-down shooter built with Unity as part of a structured game development learning roadmap.

![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-PC-blue)
![Platform](https://img.shields.io/badge/Platform-Android-green)
![License](https://img.shields.io/badge/License-MIT-green)

## Features

- **Player Movement** - WASD ile 8 yönlü hareket (Rigidbody2D, New Input System)
- **Mouse Aim** - Mouse yönüne bakan karakter (Atan2 açı hesabı)
- **Shoot System** - Sol tık ile ateş, bullet prefab, otomatik yok olma
- **Enemy AI** - Player'a doğru hareket eden düşmanlar
- **Enemy Spawner** - Spawn noktalarından otomatik düşman üretimi
- **Wave System** - Wave bazlı düşman sistemi, wave bitince yenisi başlar
- **Player Health** - Can sistemi, hasar alma, invincibility frames
- **Damage Feedback** - Hasar alınca sprite flash efekti
- **Game Over** - Player ölünce Game Over ekranı, restart butonu
- **Score System** - Enemy öldürünce score artışı, UI'da görünür
- **Upgrade System** - Wave sonrası Fire Rate, Damage, Speed upgrade seçimi
- **Player Stats** - Merkezi stat yönetimi (moveSpeed, fireRate, bulletDamage)
- **Mobile Support** - On-screen joystick, fire button, Android APK

## Controls

### PC
| Tuş | Aksiyon |
|-----|---------|
| WASD | Hareket |
| Mouse | Nişan al |
| Sol Tık | Ateş et |

### Mobile (Android)
| Kontrol | Aksiyon |
|---------|---------|
| Sol joystick | Hareket + Nişan al |
| Sağ buton | Ateş et |

## Technical Details

- **Engine:** Unity 6
- **Language:** C#
- **Input:** Unity New Input System + custom mobile input
- **Physics:** Rigidbody2D, Gravity Scale 0
- **UI:** Canvas Scaler, Safe Area support

## Development Timeline

| Versiyon | Tarih | Milestone |
|----------|-------|-----------|
| v0.1.0 | Mayıs 2026 - Hafta 1 | Movement, Aim, Shoot, Enemy, Spawn, Wave |
| v0.2.0 | Mayıs 2026 - Hafta 2 | Health, Damage Feedback, Game Over, Score |
| v0.3.0 | Mayıs 2026 - Hafta 3 | Power-ups, Upgrade UI, Wave Progression |
| v0.4.0 | Haziran 2026 - Hafta 4 | Mobile Pass, Joystick, Android Build |

---

Made with Unity