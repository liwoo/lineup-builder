# LineupBuilder ⚽️
### .NET MAUI and MauiReactor Application

put the following images in a table with 2 columns and 1 row


| Reference Home Screen | Reference Player Screen |
| --- | --- |
| ![Reference Home Screen](https://res.cloudinary.com/tiyeni/image/upload/v1704444193/squad-reference.jpg) | ![Reference Player Screen](https://res.cloudinary.com/tiyeni/image/upload/v1704444368/player-details.jpg) |


## Introduction

Welcome to the LineupBuilder app! 🚀 This README guides you through setting up and running the LineupBuilder application, a cross-platform solution for managing a soccer team's player squad, using .NET MAUI and MauiReactor.

### Motivation
I want to use [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-8.0) to build cross-platform Apps more because of how awesome C# is a language!  The problem I have (apart from the fact that I still feel .NET MAUI is in Beta and therefore the 3rd best native cross-platform option :) is [XAML](https://learn.microsoft.com/en-us/dotnet/maui/xaml/?view=net-maui-8.0) for building UIs.

However, I recently discovered [MauiReactor](https://adospace.gitbook.io/mauireactor/) which is a more Reactive and Declarative way of building UIs for .NET MAUI using C#, similar to how [SwiftUI](https://developer.apple.com/xcode/swiftui/) works. I'm sold 😍  I decided to build a simple app using .NET MAUI and MauiReactor to see how it all works and I was pleasantly surprised at how easy it was to build a simple app.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (17.8 or greater) or Visual Studio for Mac (17.6 or greater) 🖥️
- [Visual Studio Code](https://code.visualstudio.com/) (Preview) for .NET MAUI support 📝
- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) 🌐
- Microsoft OpenJDK 11 for Android development 📱
- [Xcode](https://developer.apple.com/xcode/) for iOS/macOS development 🍏
- Android SDK for Android development 🤖
- [MauiReactor](https://adospace.gitbook.io/mauireactor/) (already included in the project)

## Setup Instructions

### 🪟 Windows

- Install Visual Studio with .NET MAUI workload.
- Install .NET 8.
- Run `dotnet workload install maui` in the terminal.
- For Android debugging, install Microsoft OpenJDK 11 and Android SDK.

### 🖥️ macOS

- Install .NET 8.
- Install the latest stable Xcode.
- Run `xcode-select --install` and `dotnet workload install maui` in the terminal.
- For Android debugging, install Microsoft OpenJDK 11 and Android SDK.

## Troubleshooting

For common setup issues, please refer to the [official documentation](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Hot Reload Setup 🔄

To use the MauiReactor hot-reload feature:

### Install MauiReactor Hot-Reload Console (if not already installed):

```bash
dotnet tool install -g Reactor.Maui.HotReload #use the latest beta version for .NET 8
```

### Start Hot-Reload Console:

#### Simple Mode (Default):

```bash
dotnet-maui-reactor -f [net8.0-android|net8.0-ios|net8.0-maccatalyst|windows10.0.19041.0]
```

#### Full Mode:

```bash
dotnet-maui-reactor -f [net8.0-android|net8.0-ios|net8.0-maccatalyst|windows10.0.19041.0] --mode Full
```

Follow standard .NET MAUI procedures to run LineupBuilder on your preferred platform. 

Utilize the hot-reload feature for an enhanced development experience.