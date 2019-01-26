from user import User
from datetime import datetime
import requests
import time
import urllib3

# generating user data
# sending http requests to API

def post(data):
    r = requests.post('https://localhost:44380/api/people', json=data, verify=False)
    curr_time = datetime.now()
    formatted_time = curr_time.strftime('%M:%S.%f')
    print(str(r.status_code) + " " + formatted_time)

def main():
    urllib3.disable_warnings()
    count = 1
    list = []

    u = User()
    post(u.toJSON())
    
    #for _ in range(10):
        #time.sleep(.1)

if __name__ == '__main__':
    main()