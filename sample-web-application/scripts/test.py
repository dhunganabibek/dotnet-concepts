import requests
import json


response = requests.get('http://jsonplaceholder.typicode.com/posts')

result = response.json()

print(json.dumps(result, indent=4))