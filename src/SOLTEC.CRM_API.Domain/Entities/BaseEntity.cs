﻿namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Base entity class
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Id of the entity
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Created at
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Created by
    /// </summary>
    public string CreatedBy { get; set; }
    /// <summary>
    /// Updated at
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
    /// <summary>
    /// Updated by
    /// </summary>
    public string UpdatedBy { get; set; }
}
