<?php

class Product {
   
    public $name;
    public $price;
    public $quantity;
    public $category;

 
    public function __construct($name, $price, $quantity, $category) {
        $this->name = $name;
        $this->price = $price;
        $this->quantity = $quantity;
        $this->category = $category;
    }

    
    public function getProductInfo() {
        return "Product Name: $this->name\n" .
               "Price: ₹" . number_format($this->price, 2) . "\n" .
               "Quantity: $this->quantity\n" .
               "Category: $this->category\n";
    } 

    
    public function updateQuantity($amount) {
        $this->quantity += $amount;
        echo "Quantity updated by $amount. New quantity: $this->quantity\n";
    }

    
    public function isInStock() {
        return $this->quantity > 0;
    }

    
    public function applyDiscount($percent) {
        if ($percent > 0 && $percent <= 100) {
            $discountAmount = ($this->price * $percent) / 100;
            $this->price -= $discountAmount;
            echo "Discount of $percent% applied. New price: ₹" . number_format($this->price, 2) . "\n";
        } else {
            echo "Invalid discount percent.\n";
        }
    }


    public function restock($amount) {
        if ($amount > 0) {
            $this->quantity += $amount;
            echo "Restocked $amount items. New quantity: $this->quantity\n";
        } else {
            echo "Restock amount must be positive.\n";
        }
    }
}


$product = new Product("Laptop", 50000, 10, "Electronics");

echo $product->getProductInfo();       
$product->applyDiscount(10);         
$product->updateQuantity(-3);         
$product->restock(5);                 
echo "In Stock: " . ($product->isInStock() ? "Yes" : "No") . "\n";
echo $product->getProductInfo();      

?>