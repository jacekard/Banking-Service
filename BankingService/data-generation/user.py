from faker import Faker

class User:
    def __init__(self):
        fake = Faker('pl_PL')
        self.name = ""
        self.age = 0
        self.localization = fake.name()

    def test(self):
        print("ok")
