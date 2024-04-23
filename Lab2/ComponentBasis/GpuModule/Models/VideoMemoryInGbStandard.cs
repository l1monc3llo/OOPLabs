using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.GpuModule.Models;

public class VideoMemoryInGbStandard
{
    public VideoMemoryInGbStandard(int videoMemoryCapacity)
    {
        ValidateVideoMemoryCapacity(videoMemoryCapacity);
        Capacity = videoMemoryCapacity;
    }

    public int Capacity { get; }

    public static void ValidateVideoMemoryCapacity(int videoMemoryCapacity)
    {
        if (videoMemoryCapacity <= 0 || videoMemoryCapacity % 2 != 0)
        {
            throw new ArgumentException("Video Memory capacity cannot be non-positive or not be a power of two");
        }
    }
}