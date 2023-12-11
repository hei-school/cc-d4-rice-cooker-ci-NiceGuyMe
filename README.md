[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/PHq8Kfj_)

## Rice Cooker Simulation

This project implements a simple simulation of a rice cooker .

### Features

- Add water to the rice cooker
- Add rice to the cooker.
- Start cooking and monitor progress.
- Receive notifications when cooking is complete or rice is overcooked.

### Requirements

mono-project

<https://www.mono-project.com/download/stable/#download-lin-ubuntu>

dotnet

<https://dotnet.microsoft.com/en-us/download>

dotnet-format

<https://github.com/dotnet/format>

roslynator

<https://github.com/dotnet/roslynator>

# Run

Compile with :

```sh
csc src/RiceCooker.cs src/RiceCookerSimulation.cs
```

Run

```sh
./RiceCookerSimulation.exe
```

# Formatter

dotnet-format

to format

```sh
dotnet format
```

to check format

```sh
dotnet format --verify-no-changes
```

# Linter

to check error

```sh
roslynator analyze
```
