
forked from:

https://github.com/aspnet/ResponseCaching

because of that: 

https://github.com/aspnet/Announcements/issues/354

Decision to make IResponseCachingPolicyProvider interace as internal broke the Open-Close principal of the module and caused my application unable to case certain responses.

# Build

```
dotnet build
```

# Test

```
dotnet test
```