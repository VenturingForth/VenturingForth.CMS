using System.Text.Json.Serialization;

namespace VenturingForth.CMS.Application.Models.DTOs;

/// <summary>
/// Base class for all content body DTOs.
/// Acts as a polymorphic root for per-content-type response DTOs.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
public abstract record ContentBodyDto();

// TODO: Add more DTOs for different content types such as Post, Product, Image, Video, etc