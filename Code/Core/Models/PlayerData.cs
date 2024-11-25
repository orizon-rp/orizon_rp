﻿using System;
using System.Text.Json.Serialization;
using Mongo.Rest;

namespace Orizon.Core.Models;

[MongoCollection( "players" )]
public record PlayerData
{
	[JsonPropertyName("_id")] public string Id { get; init; } = null!;
	
	public SteamId Owner { get; init; }
	public CharacterId Character { get; init; }
	public List<CharacterId> Characters { get; init; } = null!;
	public DateTime LastLogin { get; init; }
	public DateTime CreatedAt { get; init; }
}
