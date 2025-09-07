﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThemeOptimizerSettings.cs" company="Sundews">
// Copyright (c) Sundews. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Xaml.Optimizers.Wpf.Theme;

/// <summary>
/// Settings for the <see cref="ThemeOptimizer"/>.
/// </summary>
public class ThemeOptimizerSettings
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ThemeOptimizerSettings"/> class.
    /// </summary>
    /// <param name="themesPath">The themes path.</param>
    /// <param name="themeModesPath">The theme mode path.</param>
    public ThemeOptimizerSettings(string themesPath, string themeModesPath)
    {
        this.ThemesPath = themesPath;
        this.ThemeModesPath = themeModesPath;
    }

    /// <summary>
    /// Gets the themes path, relative to the project root.
    /// </summary>
    public string ThemesPath { get; }

    /// <summary>
    /// Gets the theme mode path, relative to the Themes path.
    /// </summary>
    public string ThemeModesPath { get; }
}