import cv2  

# Read the image  
image = cv2.imread("C:/Users/LENOV/OneDrive/Pictures/Screenshots/json.png")
 
# Display the image  
cv2.imshow("C:\Users\LENOV\OneDrive\Pictures\Screenshots\json.png", image)  
cv2.waitKey(0)  # Wait for user input  
cv2.destroyAllWindows()  # Close window
