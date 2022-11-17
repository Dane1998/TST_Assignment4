# TST_Assignment4

### How do you verify that a mock was called?
To verify that a mock was called you can use the Verify() This method verifies that a specific invocation matching the given expression was performed on the mock. By adding the Times.Once, you make sure that the mocked method is only called once. 
![Mock_called](https://user-images.githubusercontent.com/56921631/202428364-b66178ef-9cae-4260-9630-82f8ee6c23ad.jpg)

### How do you verify that a mock was NOT called?
Again we would use the Verify(). This time we call Times.Never which allows us to verify that the mocked method was never called. 
![Mock_not_called](https://user-images.githubusercontent.com/56921631/202428487-b8469a92-eac3-4af7-b655-4fd697d13ae4.jpg)

### How do you specify how many times a mock should have been called?
Same as before, we will use Verify. This time we use Times.Exactly(x) to specify the times the mocked method should have been invoked. 
![Mock_exactlyjpg](https://user-images.githubusercontent.com/56921631/202428515-13787155-1f5f-4313-a5b7-6f7675c90a35.jpg)

### How do you verify that a mock was called with specific arguments?
To verify that a mock was called with a specific argument you can use the Verify() + It.Is<T>() to check the parameters passed in. 
![Mock_specific](https://user-images.githubusercontent.com/56921631/202428546-f2eb91b7-c5e4-4099-b430-ac05ab9427dc.jpg)

### Coverage Report 
![Code_coverage](https://user-images.githubusercontent.com/56921631/202438690-098bf215-a0f1-4a64-8477-6fa5e1d94b5d.jpg)

### Analyser 
![Analyser](https://user-images.githubusercontent.com/56921631/202438782-78f42d2e-afec-4891-bfe7-3b6780da63f5.jpg)

### Summary
![Summary](https://user-images.githubusercontent.com/56921631/202438809-48893b8b-266a-4b66-9f71-c2a75206cca4.jpg)
