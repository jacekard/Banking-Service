from faker import Faker
from random import randint
import json

class User:
    def __init__(self):
        fake = Faker('pl_PL')
        fake.seed(1) 

        self.Gender = "M" if randint(0,1) else "F"
        if self.Gender == 'M':
            self.Prefix = "Pan"
            self.Name = fake.first_name_male()
            self.Surname = fake.last_name_male()
        else:
            self.Prefix = "Pani"
            self.Name = fake.first_name_female()
            self.Surname = fake.last_name_female()
        
        self.Age = randint(18,100)
        self.Pesel = fake.random_number(digits=11, fix_len=True)
        self.EmailAddress = (self.Name + '.' + self.Surname + '@' + fake.free_email_domain()).lower()
        self.Address = fake.street_address()
        self.PostCode = fake.postcode()
        self.Country = fake.country()
        self.AccountNumber = fake.credit_card_number()
        self.PhoneNumber = fake.phone_number()
        self.City = fake.city()
        self.Username = fake.user_name()
        self.Password = fake.password(length=10, special_chars=True, digits=True, upper_case=True, lower_case=True)

    def __str__(self):
        return str(self.__dict__)

    def toJSON(self):
        return json.dumps(self.__dict__)