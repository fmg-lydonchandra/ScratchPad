cmake_minimum_required(VERSION 3.25)
set(CMAKE_CXX_STANDARD 17)
project(BenchmarkAht)
include(FetchContent)

# Externally provided libraries
FetchContent_Declare(googletest
        GIT_REPOSITORY https://github.com/google/googletest.git
        GIT_TAG v1.13.x)

FetchContent_Declare(googlebenchmark
        GIT_REPOSITORY https://github.com/google/benchmark.git
        GIT_TAG v1.8.0)

FetchContent_MakeAvailable(
        googletest
        googlebenchmark)

add_executable(BenchmarkAht main.cpp)
target_link_libraries(BenchmarkAht benchmark::benchmark)
