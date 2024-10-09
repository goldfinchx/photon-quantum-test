﻿using System;
using System.Diagnostics;
using Photon.Deterministic;

namespace Quantum.Gameplay.Damage;

public unsafe class DamageSystem : SystemSignalsOnly, ISignalOnAttack {
    
    public void OnAttack(Frame frame, EntityRef victim, EntityRef attacker, int damage) {
        if (!frame.Unsafe.TryGetPointer(victim, out Health* health)) {
            Log.Warn("Damaged entity does not have health component!");
            return;
        }
        
        health->Value -= damage;
    }
    
}