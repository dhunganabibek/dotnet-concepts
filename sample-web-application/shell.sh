#!/bin/bash

curl --request GET \
    --fail --verbose --include http://localhost:5272/ \
    --header "Accept: application/json" \
    --header "name: Bibek Dhunagana" \
    --data '{"name": "Bibek Dhunagana"}'
