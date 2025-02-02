﻿namespace Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;
    using Octokit.Webhooks.Converter;

    [PublicAPI]
    [WebhookEventType(WebhookEventType.Deployment)]
    [JsonConverter(typeof(WebhookConverter<DeploymentEvent>))]
    public abstract record DeploymentEvent : WebhookEvent
    {
        [JsonPropertyName("deployment")]
        public Models.DeploymentEvent.Deployment Deployment { get; init; } = null!;
    }
}
