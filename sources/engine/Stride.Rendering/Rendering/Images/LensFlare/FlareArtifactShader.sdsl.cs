﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering.Images
{
    internal static partial class FlareArtifactShaderKeys
    {
        public static readonly ValueParameterKey<float> Amount = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Vector2> ZoomOffsetsDistortions = ParameterKeys.NewValue<Vector2>();
        public static readonly ValueParameterKey<Vector3> ColorAberrations = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> AberrationStrength = ParameterKeys.NewValue<float>(0);
    }
}