# Kick.NET

C# Wrapper for accessing the (for now) unoffical API of the livestreaming platform [kick.com](https://kick.com/).

## Introduction

Currently the API for Kick is not public yet and is secured by CloudFlare. This wrapper supports the use of [FlareSolverr](https://github.com/FlareSolverr/FlareSolverr) of which a running instance is required to work around the CloudFlare protection. I will remove this workaround after Kick releases their public API which they plan to release in the upcoming weeks.

## Installation

This library is not yet available on NuGet so you're required to clone and build it yourself.

1. Clone the repo (https://github.com/michaelschattgen/kick.net.git)
2. Build the project and add the library to your own project.

## Getting Started

You can check the Kick.Example project as an example on how to use this library. Keep in mind that this library is very experimental, a lot of features are missing and is in development.

Instantiate a new KickClient in your application.

or

Register the KickApiClient in your Program.cs and use the KickClient through Dependency Injection:

```csharp
builder.Services.AddKickApiClient(httpClient =>
{
    httpClient.BaseAddress = Endpoints.KickBaseUrl;
}, _configuration.GetValue<bool>("UseFlareSolverr"));
```

## Usage

Kick.NET supports the retrieval of Channels, Livestreams and Users, more will be added in the near future.

### Channel

The Channel endpoint returns information about the specified channel including: id, slug, follower count, verified, chatroom info and much more.

```csharp
var channel = await _kickClient.Channels.Get(channelName);
```

### User

The User endpoint return infromation about the specified user including: id, bio, social links and profile picture.

```csharp
var user = await _kickClient.Users.Get(username);
```

### Livestream

The Livestream endpoint returns information about the channel in case the user is streaming. This includes id, slug, title, createdAt, language, the amount of viewers and more.

```csharp
var user = await _kickClient.Livestream.Get(channelname);
```

## License

The source code of this project is licensed under the [GNU license](LICENSE).
