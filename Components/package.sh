#!/bin/sh

VERSION=$1
if [ -z "$VERSION" ]; then
    echo "Must specify version."
    exit 1
fi

zip LiveSplit.AlternateTimingMethod_v${VERSION}.zip LiveSplit.AlternateTimingMethod.dll ../README.txt