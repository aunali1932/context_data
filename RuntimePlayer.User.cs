﻿using Photon.Deterministic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quantum {
  partial class RuntimePlayer {

    public string Nickname;
    partial void SerializeUserData(BitStream stream)
    {
      // implementation
      stream.Serialize(ref Nickname);
    }
  }
}
