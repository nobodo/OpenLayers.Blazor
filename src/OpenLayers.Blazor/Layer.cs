﻿using Microsoft.AspNetCore.Components;

namespace OpenLayers.Blazor;

public class Layer : ComponentBase
{
    internal Internal.Layer _internalLayer = new();

    internal Internal.Layer InternalLayer => _internalLayer;

    [CascadingParameter] public Map? ParentMap { get; set; }

    [Parameter]
    public double Opacity
    {
        get => _internalLayer.Opacity;
        set => _internalLayer.Opacity = value;
    }

    [Parameter]
    public bool Visibility
    {
        get => _internalLayer.Visibility;
        set => _internalLayer.Visibility = value;
    }

    [Parameter]
    public double[]? Extent
    {
        get => _internalLayer.Extent;
        set => _internalLayer.Extent = value;
    }

    [Parameter]
    public int? ZIndex
    {
        get => _internalLayer.ZIndex;
        set => _internalLayer.ZIndex = value;
    }

    [Parameter]
    public double? MinResolution
    {
        get => _internalLayer.MinResolution;
        set => _internalLayer.MinResolution = value;
    }

    [Parameter]
    public double? MaxResolution
    {
        get => _internalLayer.MaxResolution;
        set => _internalLayer.MaxResolution = value;
    }

    [Parameter]
    public double? MinZoom
    {
        get => _internalLayer.MinZoom;
        set => _internalLayer.MinZoom = value;
    }

    [Parameter]
    public double? MaxZoom
    {
        get => _internalLayer.MaxZoom;
        set => _internalLayer.MaxZoom = value;
    }

    [Parameter]
    public string? Class
    {
        get => _internalLayer.ClassName;
        set => _internalLayer.ClassName = value;
    }

    [Parameter]
    public string? Url
    {
        get => _internalLayer.Source.Url;
        set => _internalLayer.Source.Url = value;
    }

    [Parameter]
    public string[]? Urls
    {
        get => _internalLayer.Source.Urls;
        set => _internalLayer.Source.Urls = value;
    }

    [Parameter]
    public SourceType SourceType
    {
        get => _internalLayer.Source.SourceType;
        set => _internalLayer.Source.SourceType = value;
    }

    [Parameter]
    public string? Attributions
    {
        get => _internalLayer.Source.Attributions;
        set => _internalLayer.Source.Attributions = value;
    }

    [Parameter]
    public string? CrossOrigin
    {
        get => _internalLayer.Source.CrossOrigin;
        set => _internalLayer.Source.CrossOrigin = value;
    }

    [Parameter]
    public Dictionary<string, object> Params
    {
        get => _internalLayer.Source.Params;
        set => _internalLayer.Source.Params = value;
    }

    [Parameter]
    public string? Key
    {
        get => _internalLayer.Source.Key;
        set => _internalLayer.Source.Key = value;
    }

    [Parameter]
    public BingMapImagerySet? ImagerySet
    {
        get => _internalLayer.Source.ImagerySet != null ? Enum.Parse<BingMapImagerySet>(_internalLayer.Source.ImagerySet) : null;
        set => _internalLayer.Source.ImagerySet = value.ToString();
    }

    [Parameter]
    public double Gutter
    {
        get => _internalLayer.Source.Gutter;
        set => _internalLayer.Source.Gutter = value;
    }

    [Parameter]
    public bool WrapX
    {
        get => _internalLayer.Source.WrapX;
        set => _internalLayer.Source.WrapX = value;
    }

    [Parameter]
    public bool Transition
    {
        get => _internalLayer.Source.Transition;
        set => _internalLayer.Source.Transition = value;
    }

    [Parameter]
    public double ZDirection
    {
        get => _internalLayer.Source.ZDirection;
        set => _internalLayer.Source.ZDirection = value;
    }

    [Parameter]
    public double Preload
    {
        get => _internalLayer.Preload;
        set => _internalLayer.Preload = value;
    }

    [Parameter]
    public string? ServerType
    {
        get => _internalLayer.Source.ServerType;
        set => _internalLayer.Source.ServerType = value;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        if (ParentMap != null) ParentMap.LayersList.Add(this);
    }
}