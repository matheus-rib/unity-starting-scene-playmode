# Unity Starting Scene Playmode
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/matheus-rib/unity-starting-scene-playmode/blob/main/LICENSE.md)

A script made for Unity. It allows to either auto play the the first scene of your building settings when the current opened scene is part of the build list, or play the current scene when it's not part of it.

## Table of content:
- [Why?](#why)
- [How to setup and use](#how-to-setup-and-use)
- [Troubleshooting](#troubleshooting)

## Why?
When you have scripts that are loaded in your first scene (eg: Main Menu to select a character, saved entry or level) you don't need to switch between the current scene you're working on to the first needed scene to properly load the game, it will always load the first scene of the build list (as long the current scene is also in the build list). Otherwise, the current scene will be played.

## How to setup and use
- Drag the content inside `scripts` folder to you `Assets` folder in your project. 
- Wait for the script to be compiled and hit play on desired scene to test it.

## Troubleshooting
If you switch the first scene on the build list, you must reload the entire Editor.
