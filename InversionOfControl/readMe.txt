Example :

In procedural programming, a chunk of code thats uses or consumes another chunk of code is in control of 
the process.It exactly knows what piece of code it usesand what method is present in a class.And in doing so,
it may be possible that it knows some of the implementation details in the code it uses.

When class X uses class Y, does X really needs to know that it uses Y?
Or it needs to know the general behavior of Y, without knowing the exact details of Y  (or could we say "of the instance of Y??")

By extracting an abstract