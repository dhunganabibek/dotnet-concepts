#!/bin/bash

curl --request POST \
    --fail --verbose --include http://localhost:5272/ \
    --header "Accept: application/json" \
    --header "name: Bibek Dhunagana" \
    --data '{"name": "Bibek Dhunagana"}'
