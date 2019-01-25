from faker import Faker

class User:
    def __init__(self):
        fake = Faker('pl_PL')
        self.Name = ""
        self.Surname = ""
        self.Pesel = ""
        self.EmailAddress = ""
        self.Address = ""
        self.Country = ""
        self.AccountNumber = ""
        self.PhoneNumber = ""

    def test(self):
        print("ok")
