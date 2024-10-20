import requests
import json
import test


response = requests.get('http://jsonplaceholder.typicode.com/posts')

result = response.json()

json.dumps(result, indent=4)

print(__name__)