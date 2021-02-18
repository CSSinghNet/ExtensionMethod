# ExtensionMethod
Extension Method in C#

It allow you to add functionalities to an existing class
- without inheriting it.
- without recompiling it.
- without otherwise modifying the original type.

Steps to create an Extension Method

# Step 1: Define a static visible class which will contain the Extension Method or Extension Methods. Make sure the class is visible to the client code by applying the appropriate accede modifier.

# Step 2: Create a static method with at least the same visibility level as the containing class.

# Step 3: The first parameter of the Extension Method always specifies the type method operates on. Make sure the type name is preceded with the “this” modifier.

# Step 4: In the calling code, add the namespace that contains Extension Method class.

# Step 5: Use the Extension Method on the type in the same instance method can be used. Keep in mind that we do not need to pass the first parameter because that denotes the type, however we should pass the second parameter onwards to call the extension method.

