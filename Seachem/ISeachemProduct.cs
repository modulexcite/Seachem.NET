﻿namespace Seachem
{
    public interface ISeachemProduct
    {
        /// <summary>
        ///     Product name.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Input parameters.
        /// </summary>
        SeachemParameter[] Parameters { get; }

        /// <summary>
        ///     Product comment.
        /// </summary>
        string Comment { get; }

        /// <summary>
        ///     Calculate dosage requirements.
        /// </summary>
        /// <returns>Returns an array of dosages.</returns>
        SeachemDosage[] Calculate();
    }
}