# ReqDotNet
Easy and fast HTTP library for .NET Framework.

- .NET Framework version required : **4.5**
- Current library version : **1.1.0**

# Changelog
- Fixed a problem with the UserAgent class, the code is also cleaner to see.
- Some User-Agents should now be faster to load due to removing useless things.
- Added function CookieStorage.Contains() (it's pretty much self-explanatory).
- Requests.SendRequest() function now converts string address to a Uri (client.BaseAddress).
- Removed UserAgent.Random() function, it was glitched.
- Removed all non-working Bots User-Agents (Duckduckbot, SogouPicspider, Sogouheadspider, Sogouwebspider and SogouOrionspider).

# Example
````
Requests r = new Requests()
{
  Method = HttpMethod.Get,
  Address = "https://www.nitrxgen.net/md5db/" + hash,
  UserAgent = UserAgent.Random(),
  Timeout = 5000
};

string response = await r.SendRequestToString();
if (!string.IsNullOrEmpty(response))
{
  // md5 is correct
}
else
{
  // md5 isn't correct
}
````

If you encounter some bugs with the library, please report them in the project's issues so I can fix them ASAP!

# License
This project is free and oepn-source AND it's on the **MIT License**, meaning you can do pretty much everything with the project like modify it or **even sell closed copies!** Cool, right?

# Donation
Did this project save your time? Was it helpful / easy to use? If yes, then consider donating me (even a little) so I can buy myself a cup of coffee!
PayPal : **erruption.selly@gmail.com** - Bitcoin : **1Q8dZDTDxzJ1YLbm4fYfEK8KvDq86LFucU**

# Fork the project
If there are some things that seems bad to you or even bugs but you don't want to report them because you're not cool, then you can fork the project and modify / fix / add things!
