#pragma once
#include <vector>
#include <iostream>
#include <cstdlib>
#include <cassert>
#include <cmath>
#include <fstream>
#include <sstream>
#include "trainingSet.h"
#include "neuron.h"
#include "net.h"
#include <stdio.h>
#include <tchar.h>
#include <SDKDDKVer.h>
class trainingSet
{
public:
	trainingSet(const std::string filename);
	bool isEOF() { return trainingDataFile.eof(); }
	void getTopology(std::vector<unsigned> &topology);
	unsigned getNextInputs(std::vector<double> &inputVals);
	unsigned getTargetOutputs(std::vector<double> &targetOutputVals);
private:
	std::ifstream trainingDataFile;
};
