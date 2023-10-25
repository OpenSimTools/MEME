﻿using ReactiveUI;
using System.Reactive;

namespace AME.GUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string? mass;
    public string? Mass
    {
        get => mass;
        set => this.RaiseAndSetIfChanged(ref mass, value);
    }

    private string? bodyDragBase;
    public string? BodyDragBase
    {
        get => bodyDragBase;
        set => this.RaiseAndSetIfChanged(ref bodyDragBase, value);
    }

    private string? generalTorqueMult;
    public string? GeneralTorqueMult
    {
        get => generalTorqueMult;
        set => this.RaiseAndSetIfChanged(ref generalTorqueMult, value);
    }

    private string? generalPowerMult;
    public string? GeneralPowerMult
    {
        get => generalPowerMult;
        set => this.RaiseAndSetIfChanged(ref generalPowerMult, value);
    }

    private string? maxForceAtSteeringRack;
    public string? MaxForceAtSteeringRack
    {
        get => maxForceAtSteeringRack;
        set => this.RaiseAndSetIfChanged(ref maxForceAtSteeringRack, value);
    }

    private string? pneumaticTrail;
    public string? PneumaticTrail
    {
        get => pneumaticTrail;
        set => this.RaiseAndSetIfChanged(ref pneumaticTrail, value);
    }

    private string? pneumaticTrailGripFractPower;
    public string? PneumaticTrailGripFractPower
    {
        get => pneumaticTrailGripFractPower;
        set => this.RaiseAndSetIfChanged(ref pneumaticTrailGripFractPower, value);
    }

    public ReactiveCommand<Unit, Unit> OpenCommand { get; }
    public ReactiveCommand<Unit, Unit> SaveCommand { get; }

    public MainWindowViewModel()
    {
        OpenCommand = ReactiveCommand.Create(Open);
        SaveCommand = ReactiveCommand.Create(Save);
    }

    public void Open()
    {
        System.Diagnostics.Debug.WriteLine($"Open Command");
    }

    public void Save()
    {
        System.Diagnostics.Debug.WriteLine($"Save Command");
    }
}
