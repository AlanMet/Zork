# 🧟 Zork Remake in C# — Custom Text Adventure Engine

A modern and complex remake of the classic **Zork** text adventure, written in C#.  
This version goes beyond a basic recreation and includes a **robust command parser**, **dynamic vocabulary system**, and quality-of-life features like **"Did you mean...?"** suggestions.

> ✨ Built from scratch in C# using .NET, designed for extensibility and natural language parsing.

---

## 🧠 Features

- ✅ Complex text parser with multi-word command support
- 🧭 Directional movement (`north`, `northeast`, `u`, `down`, etc.)
- 📦 Full inventory and object interaction system
- 💬 Typo correction using **Levenshtein distance** ("Did you mean `take lamp`?")
- 🧠 Word type tagging (`verb`, `noun`, `preposition`, etc.)
- 💾 Save/load system (planned or implemented)
- 🪞 Descriptive world with rooms, objects, and lore
- 🧱 Modular architecture for rooms, items, and player logic

---

## 🧰 Vocabulary System

Each input word is classified with a type:

- **Verbs**: `go`, `take`, `open`, `read`, `look`, `put`, etc.
- **Nouns**: `mailbox`, `lamp`, `leaflet`, `rope`, `trophycase`, etc.
- **Prepositions**: `with`, `in`, `on`, `under`, `at`, etc.
- **Other**: `the`, etc.

This system allows you to support natural commands like:
put lamp in case
read leaflet
open the mailbox
go north
take all

---

## 🚀 Getting Started

1. download exe from: [here](https://github.com/AlanMet/Zork/blob/main/zrok/zrok/bin/Debug/zrok.exe)
2. Optional: clone repo and run directly.
