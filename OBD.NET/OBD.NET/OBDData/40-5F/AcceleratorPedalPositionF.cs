﻿using OBD.NET.DataTypes;

namespace OBD.NET.OBDData._40_5F;

public class AcceleratorPedalPositionF : AbstractOBDData
{
    #region Properties & Fields

    public Percent Position => new(A / 2.55, 0, 100);

    #endregion

    #region Constructors

    public AcceleratorPedalPositionF()
        : base(0x4B, 1)
    { }

    #endregion

    #region Methods

    public override string ToString() => Position.ToString();

    #endregion
}