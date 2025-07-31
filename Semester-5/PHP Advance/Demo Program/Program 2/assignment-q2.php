<?php

class Bank {
    
      public $accountNumber;
    public $accountHolder;
    public $balance;

    
    public function __construct($accountNumber, $accountHolder, $balance = 0) {
        $this->accountNumber = $accountNumber;
        $this->accountHolder = $accountHolder;
        $this->balance = $balance;
    }

    
    public function deposit($amount) {
        if ($amount > 0) {
            $this->balance += $amount;
            echo "Deposited ₹$amount successfully.\n";
        } else {
            echo "Please enter a valid amount to deposit.\n";
        }
    }

    
    public function withdraw($amount) {
        if ($amount > 0 && $amount <= $this->balance) {
            $this->balance -= $amount;
            echo "Withdrawn ₹$amount successfully.\n";
        } else {
            echo "Not enough balance or invalid amount.\n";
        }
    }

    
    public function getBalance() {
        return $this->balance;
    }

    
    public function getAccountInfo() {
        return "Account Number: $this->accountNumber\n" .
               "Account Holder: $this->accountHolder\n" .
               "Current Balance: ₹" . number_format($this->balance, 2) . "\n";
    }
}


$myAccount = new Bank("9876543210", "Jaydeep Gohil");
$myAccount->deposit(1000);      
$myAccount->withdraw(300);  
$myAccount->getAccountInfo();  
