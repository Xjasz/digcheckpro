#!/usr/bin/env bash

if which node > /dev/null
then
    echo "Installing appcenter."
	npm install -g appcenter-cli
else
    echo "Node needs to be installed."
fi