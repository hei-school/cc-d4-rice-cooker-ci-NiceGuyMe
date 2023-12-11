[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/PHq8Kfj_)

## Rice Cooker Simulation

This project implements a simple simulation of a rice cooker using Python.

### Features:

- Add water and rice to the cooker.
- Start cooking and monitor progress.
- Receive notifications when cooking is complete or rice is overcooked.

## C++

g++ riceCooker.cpp main.cpp

execute ./a.out

# Formatter

ClangFormat

https://clang.llvm.org/docs/ClangFormat.html

sudo apt install clang-format

clang-format -style=google -dump-config > .clang-format

clang-format -i \*.cpp

# Linter

cpplint

https://github.com/cpplint/cpplint

check

cpplint src/main.cpp src/RiceCooker.h src/riceKooker.cpp
